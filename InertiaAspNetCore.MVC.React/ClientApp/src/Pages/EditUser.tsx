import { router } from '@inertiajs/react'
export default function EditFormUser(props: { id: number; firstName: string; lastName: string; }) {
    function submit(form: React.FormEvent<HTMLFormElement>) {
        event?.preventDefault();
        const formData = new FormData(form.currentTarget);
        router.post(`/users/${props.id}/edit`,formData)
    }
    return (
        <>
            <form onSubmit={submit}>
                <div>
                    <label>First name</label>
                    <input type="text" name="firstName" defaultValue={props.firstName} />
                </div>
                <div>
                    <label>Last name</label>
                    <input type="text" name="lastName" defaultValue={props.lastName} />
                </div>
                <div>
                    <button type="submit">Save</button>
                </div>
            </form>
        </>
    );
}
